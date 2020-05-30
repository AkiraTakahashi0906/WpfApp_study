using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Objects
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(string name)
        {
            Name = name;
        }
        public Customer(int id , string name)
        {
            Id = id;
            Name = name;
        }
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Name}-{Phone}";
        }

    }
}
