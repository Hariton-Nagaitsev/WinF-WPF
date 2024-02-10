using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EditPerson
{
    [Serializable, XmlRoot(Namespace = "http://www.MyCompany.com")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get { return Age; }
            set { Age = value; }
        }

        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст: " + Age + "\n";
        }
    }

}
