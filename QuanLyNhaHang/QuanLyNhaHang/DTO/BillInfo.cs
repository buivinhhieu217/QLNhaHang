using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class BillInfo
    {
        private int iD;
        private int count;
        private int billID;
        private int foodID;

        public BillInfo(int id, int count, int billID, int foodID)
        {
            this.ID = id;
            this.Count = count;
            this.BillID = billID;
            this.FoodID = foodID;
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

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int BillID
        {
            get
            {
                return billID;
            }

            set
            {
                billID = value;
            }
        }

        public int FoodID
        {
            get
            {
                return foodID;
            }

            set
            {
                foodID = value;
            }
        }
       
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Count = (int)row["Count"];
            this.BillID = (int)row["idBill"];
            this.FoodID = (int)row["idFood"];
        }
    }
}
