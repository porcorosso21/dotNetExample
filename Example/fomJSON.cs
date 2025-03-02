using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Text.Json;

namespace dotNetExample.Example
{
    public partial class fomJSON: Form
    {
        public fomJSON()
        {
            InitializeComponent();
        }

        private class Employee
        {
            public String EmpID { get; set; }
            public String EmpName { get; set; }
            public DateTime EmpBirthday { get; set; }
        }

        [DataContract]
        private class Person
        {
            [DataMember]
            public String ID { get; set; }
            [DataMember]
            public String Name { get; set; }
            [DataMember]
            public DateTime Birthday { get; set; }
        }

        private void btnSerialize1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpID = "A123";
            emp.EmpName = "John Doe";
            emp.EmpBirthday = DateTime.Now.AddYears(-35);

            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = js.Serialize(emp);//序列化
            tbJson1.Text = json;
        }

        private void btnDeserialize1_Click(object sender, EventArgs e)
        {
            if (tbJson1.Text == String.Empty) { return; }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Employee emp =  js.Deserialize<Employee>(tbJson1.Text);
            MessageBox.Show("EmpName = " + emp.EmpName);

        }

        private void btnSerialize2_Click(object sender, EventArgs e)
        {
            Person emp = new Person();
            emp.ID = "A123";
            emp.Name = "John Doe";
            emp.Birthday = DateTime.Now.AddYears(-35);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, emp);
                string json = Encoding.UTF8.GetString(stream.ToArray());
                tbJson2.Text = json;
            }
        }

        private void btnDeserialize2_Click(object sender, EventArgs e)
        {
            if (tbJson2.Text == String.Empty) { return; }

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(tbJson2.Text)))
            {
                Person person = (Person)serializer.ReadObject(stream);
                MessageBox.Show("ID = " + person.ID);
            }
        }

        private void btnSerialize3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpID = "A123";
            emp.EmpName = "John Doe";
            emp.EmpBirthday = DateTime.Now.AddYears(-35);

            String json = JsonConvert.SerializeObject(emp);
            tbJson3.Text = json;
        }

        private void btnDeserialize3_Click(object sender, EventArgs e)
        {
            if (tbJson3.Text == String.Empty) { return; }

            Employee emp = JsonConvert.DeserializeObject<Employee>(tbJson3.Text);
            MessageBox.Show("Birthday = " + emp.EmpBirthday.ToString("yyyy/MM/dd HH:mm:ss"));
        }

        private void btnSerialize4_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpID = "A123";
            emp.EmpName = "John Doe";
            emp.EmpBirthday = DateTime.Now.AddYears(-35);

            String json = System.Text.Json.JsonSerializer.Serialize(emp);
            tbJson4.Text = json;
        }

        private void btnDeserialize4_Click(object sender, EventArgs e)
        {
            if (tbJson4.Text == String.Empty) { return; }
            Employee emp = System.Text.Json.JsonSerializer.Deserialize<Employee>(tbJson4.Text);
            MessageBox.Show("EmpName = " + emp.EmpName);
        }
    }
}
