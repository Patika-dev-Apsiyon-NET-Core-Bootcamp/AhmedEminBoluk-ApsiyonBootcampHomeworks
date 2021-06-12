using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RoleHomeWorkProject
{
    public static class EnumExtension
    {
        public static string Description(this Enum enumerition)
        {
            var attribute = Text<DescriptionAttribute>(enumerition);

            return attribute.Description;
        }


        public static T Text<T>(Enum enumerition) where T : Attribute
        {


            Type type = enumerition.GetType();

            var memberInfos = type.GetMember(enumerition.ToString());

            if (memberInfos.Any())
                throw new ArgumentException("");

            var attributes = memberInfos[0].GetCustomAttributes(typeof(T), false);
            if (attributes.Any()) throw new ArgumentException("");

            return attributes.Single() as T;

        }
    }
}
