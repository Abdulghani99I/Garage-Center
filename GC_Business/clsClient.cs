using CarsManagement_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientBuisness
{
    public class clsClient
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int ClientID { set; get; }

        public string CarName { set; get; }

        public string ChassisNumber {  set; get; }

        public string OwnerName { set; get; }

        public string CarColor { set; get; }

        public string Description { set; get;}
        public DateTime StartDate { set; get;}
        public DateTime EndDate { set; get;}

        public string CardValidityPeriod { set; get; }


        public clsClient()
        {
            ClientID = -1;
            CarName = string.Empty;
            ChassisNumber = string.Empty;
            OwnerName = string.Empty;
            CarColor = string.Empty;
            Description = string.Empty;
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
            CardValidityPeriod = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsClient(int ClientID, string CarName, string ChassisNumber, string OwnerName, string CarColor, string Description, DateTime StartDate, DateTime EndDate, string CardValidityPeriod)
        {
            this.ClientID = ClientID;
            this.CarName = CarName;
            this.ChassisNumber = ChassisNumber;
            this.OwnerName = OwnerName;
            this.CarColor = CarColor;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.CardValidityPeriod = CardValidityPeriod;

            Mode = enMode.Update;
        }

        public static DataTable GetAllClient()
        {
            return clsClientData.GetAllClients();
        }

        public static clsClient FindByClientID(int ClientID)
        {
            string CarName = string.Empty,
            ChassisNumber = string.Empty,
            OwnerName = string.Empty,
            CarColor = string.Empty,
            Description = string.Empty,
            CardValidityPeriod = string.Empty;
            DateTime StartDate = DateTime.MinValue, EndDate = DateTime.MinValue;



            bool IsFound = clsClientData.GetClientInfoClientID
                                (ClientID, ref CarName, ref ChassisNumber, ref OwnerName, ref CarColor, ref Description, ref StartDate, ref EndDate, ref CardValidityPeriod);


            if (IsFound)
                return new clsClient(ClientID, CarName, ChassisNumber, OwnerName, CarColor, Description, StartDate, EndDate, CardValidityPeriod);
            else
                return null;
        }

        public static bool DeleteClientByID(int ClientID)
        {
            return clsClientData.DeleteClientByID(ClientID);
        }

        private bool _UpdateClient()
        {
            return clsClientData.UpdateClient(ClientID, CarName, ChassisNumber, OwnerName, CarColor, Description, StartDate, EndDate);
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                        return true;
                    break;

                case enMode.Update:
                    if (_UpdateClient())
                        return true;
                    break;
            }

            return false;
        }

        private bool _AddNewClient()
        {
            ClientID = clsClientData.AddNewClient(OwnerName, CarName, ChassisNumber, CarColor, Description, StartDate, EndDate);

            return (ClientID != -1);
        }
    }
}
