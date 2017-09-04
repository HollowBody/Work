using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRSClientApplication.Proxy;
using KRSServerApplication.Models;

namespace KRSClientApplication
{
    public interface IPalletStrategy
    {
        Pallet ChangeStatusToSend(int id, DateTime od, DateTime cd, int currentCount, int typeid, string status);
        Pallet ChangeStatusToClose(int id, DateTime od, int currentCount, int typeid, string status);
        IEnumerable GetAll();
        IEnumerable GetWithStatus(string status);
        List<string> GetHeaders();
    }
    class PalletsStrategy : IPalletStrategy
    {
        private readonly PalletProxy _palletProxy;
        private readonly List<string> _headerList = new List<string>();
        //public readonly string status = "";
        public PalletsStrategy(PalletProxy palletProxy)
        {
            _palletProxy = palletProxy;
        }

        public IEnumerable GetAll()
        {
            var all = _palletProxy.GetPallets();
            return all;
        }

        public IEnumerable GetWithStatus(string status)
        {
            var allwStatus = _palletProxy.GetPalletsWithStatus(status);
            return allwStatus;
        }

        public List<string> GetHeaders()
        {
            _headerList.Add("ID");
            _headerList.Add("Дата открытия");
            _headerList.Add("Дата закрытия");
            _headerList.Add("Дата отправки");
            _headerList.Add("Статус");
            _headerList.Add("Текущее количество шкур");
            _headerList.Add("Тип шкуры");
            return _headerList;
        }


        public Pallet ChangeStatusToSend(int id,DateTime od,DateTime cd,int currentCount,int typeid, string status)
        {
            Pallet pallet = new Pallet { IdPallet = id, Status = status, OpeningDate = od,ClosingDate = cd,SendingDate = DateTime.Now,CurrentCountSkins = currentCount,IdTypeSkin =typeid };
            var result = _palletProxy.ChangePallets(pallet);
            return result;
        }
        public Pallet ChangeStatusToClose(int id, DateTime od, int currentCount, int typeid, string status)
        {
            Pallet pallet = new Pallet { IdPallet = id, Status = status, OpeningDate = od,ClosingDate = DateTime.Now,CurrentCountSkins = currentCount,IdTypeSkin = typeid};
            var result = _palletProxy.ChangePallets(pallet);
            return result;
        }
    }

}

