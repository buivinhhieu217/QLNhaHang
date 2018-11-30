using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Food
    {
        private int iD;
        private string name;
        private float price;
        private int categoryID;

        public Food(int id, string name, float price, int categoryID)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.CategoryID = categoryID;
        }

        public Food (DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["nameFood"].ToString();
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.CategoryID =(int)row["idCategory"];
        }
        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int CategoryID
        {
            get
            {
                return categoryID;
            }

            set
            {
                categoryID = value;
            }
        }
    }
}
