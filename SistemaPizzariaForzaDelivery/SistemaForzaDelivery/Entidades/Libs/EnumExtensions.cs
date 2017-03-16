using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Libs;
using Entidades.InfraestruturaBD;

namespace Entidades.Libs
{
    public static class EnumExtensions
    {


        /// <summary>
        ///	Receberá o valor da string para um dado valor enums
        /// Só funcionam se você atribuir o atributo StringValue para os itens em sua enumeração
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetStringValue(this Enum value)
        {
            Type type = value.GetType();

            FieldInfo fieldInfo = type.GetField(value.ToString());

            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];

            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }

        public static List<IEntidade> EnumToList<T>()
        {
            var enumType = typeof(T);

            var list = new List<IEntidade>();

            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T must be of type System.Enum");

            foreach (var value in Enum.GetValues(enumType))
            {
                var enumValue = (Int32)value;
                var fi = value.GetType().GetField(value.ToString());
                var customAttributes = fi.GetCustomAttributes(typeof(StringValueAttribute), false);
                StringValueAttribute attribute = null;
                if (customAttributes.Length > 0)
                    attribute = (StringValueAttribute)customAttributes[0];
                var item = new ListItem
                {
                    Titulo = attribute != null
                            ? attribute.StringValue
                            : Enum.GetName(enumType, enumValue),
                    Codigo = Convert.ToInt32(enumValue)
                };
                list.Add(item);
            }
            return list;
        }
    }
}
