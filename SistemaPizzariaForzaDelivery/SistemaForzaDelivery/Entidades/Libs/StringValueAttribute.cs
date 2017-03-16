using System;

namespace Libs
{
	/// <summary>
	/// Este attribute é usado para representar o valor da string para um enum
	/// </summary>
	public class StringValueAttribute : Attribute
	{
		#region Properties
		public string StringValue { get; protected set; }
		#endregion
		#region Constructor
		public StringValueAttribute(string value)
		{
			this.StringValue = value;
		}
		#endregion
	}
}
