using System;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Entidades.Tipos;
using UserInterface.Pesquisas;
using Entidades.Libs;

namespace UserInterface.Modulos
{
    public static class Funcoes
    {
        public static DateTime? AbreCalendario(MaskedTextBox mskBox, PosicaoCalendario posicao)
        {
            var oFrm = new FrmCalendario();
            switch (posicao)
            {
                case PosicaoCalendario.Abaixo:
                    oFrm.Top = mskBox.PointToScreen(Point.Empty).Y + mskBox.Height - 2;
                    oFrm.Left = mskBox.PointToScreen(Point.Empty).X - 2;
                    break;
                case PosicaoCalendario.Acima:
                    oFrm.Top = mskBox.PointToScreen(Point.Empty).Y - oFrm.Height - 10;
                    oFrm.Left = mskBox.PointToScreen(Point.Empty).X;
                    break;
            }
            oFrm.ShowDialog();
            if (oFrm.IsRetValido) return oFrm.DtSaida;
            else if (!RemoverMascara(mskBox).Equals(String.Empty)) return Convert.ToDateTime(mskBox.Text);
            return null;
        }

        public static String RemoverEspacosVazios(String str)
        {
            return str.Trim().Replace(ComparadorString.Espaco.GetStringValue(), ComparadorString.Vazio.GetStringValue());
        }

        public static String RemoverZeros(String str)
        {
            return RemoverEspacosVazios(str).Replace(ComparadorString.Zero.GetStringValue(), ComparadorString.Vazio.GetStringValue());
        }

        public static String RemoverMascara(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var str = RemoverEspacosVazios(maskedTextBox.Text);
            maskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return str;
        }

        public static DateTime? ExtrairData(MaskedTextBox maskedTextBox)
        {
            var str = RemoverMascara(maskedTextBox);
            return str == String.Empty ? (DateTime?)null : Convert.ToDateTime(maskedTextBox.Text);
        }

        public static Boolean ValidarData(MaskedTextBox maskedTextBox)
        {
            var strDt = RemoverEspacosVazios(maskedTextBox.Text);
            if (RemoverMascara(maskedTextBox) == ComparadorString.Vazio.GetStringValue()) return true;
            var dDtMinima = DateTime.MinValue;
            var bFlag = DateTime.TryParse(strDt, out dDtMinima);
            if (!bFlag) ExibeMensagemDataInvalida(maskedTextBox);
            return bFlag;
        }

        public static Boolean ValidarDatas(MaskedTextBox maskedTextBoxDtInicial, MaskedTextBox maskedTextBoxDtFinal)
        {
            return Convert.ToDateTime(maskedTextBoxDtInicial.Text) <= Convert.ToDateTime(maskedTextBoxDtFinal.Text);
        }

        public static Boolean ValidarDatasPorOrdem(MaskedTextBox maskedTextBoxDtInicial, MaskedTextBox maskedTextBoxDtFinal, OrdemValidacaoDatas ordemValidacao, String strTitulo)
        {
            if (ordemValidacao == OrdemValidacaoDatas.DataInicial)
            {
                if (!ValidarData(maskedTextBoxDtInicial))
                {
                    SelecionarCampoMsk(maskedTextBoxDtInicial);
                    return false;
                }
                else
                {
                    if (RemoverMascara(maskedTextBoxDtFinal) != String.Empty)
                    {
                        if (!ValidarDatas(maskedTextBoxDtInicial, maskedTextBoxDtFinal))
                        {
                            MessageBox.Show(@"A Data Inicial não pode ser porterior a data final. Tente novamente!", strTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SelecionarCampoMsk(maskedTextBoxDtInicial);
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (!ValidarData(maskedTextBoxDtFinal))
                {
                    SelecionarCampoMsk(maskedTextBoxDtFinal);
                    return false;
                }
                else
                {
                    if (RemoverMascara(maskedTextBoxDtInicial) != String.Empty)
                    {
                        if (!ValidarDatas(maskedTextBoxDtInicial, maskedTextBoxDtFinal))
                        {
                            MessageBox.Show(@"A Data Final não pode ser Anterior a data inicial. Tente novamente!", strTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SelecionarCampoMsk(maskedTextBoxDtFinal);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static void ExibeMensagemDataInvalida(MaskedTextBox maskedTextBox)
        {
            MessageBox.Show(@"A data informada é inválida. Tente novamente!", @"Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            maskedTextBox.Select();
        }

        public static String BuscarMacAddress()
        {
            return (from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                          ).FirstOrDefault();
        }
        public static String GerarChaveTemporaria()
        {
            var thisDay = DateTime.Now;
            var strChave = BuscarMacAddress() + Convert.ToDateTime(thisDay).ToString("ddMMyyyy") + Convert.ToDateTime(thisDay).ToString("HHmmss");
            return strChave;
        }

        public static void SelecionarCampo(TextBox textBox)
        {
            textBox.Focus();
            textBox.Select();
        }

        public static void SelecionarCampoMsk(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.Focus();
            maskedTextBox.SelectAll();
        }

        public static void RemoverItemListView(ListView lvl)
        {
            if (lvl.SelectedIndices.Count <= 0)
            {
                MessageBox.Show(@"Você deve selecionar o item para excluir!", @"Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lvl.Items.RemoveAt(Convert.ToInt32(lvl.SelectedIndices[0]));
        }

        public static void ExibirMessageBoxButtonOk(TipoMensagem tipoMensagem, string tituloBox, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            MessageBox.Show(tipoMensagem.GetStringValue(), tituloBox, messageBoxButtons, messageBoxIcon);
        }
    }
}
