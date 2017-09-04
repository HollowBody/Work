using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KRSClientApplication.Proxy;
using KRSServerApplication.Models;

namespace KRSClientApplication
{
    public interface ICatalogsStrategy
    {
        //object Add(string name);
        //bool Delete(string id);
        //bool Change(string name, int id);
        Task<IEnumerable> GetAll();

        List<string> GetHeaders();
    }


    public class AdresseesCatalogStrategy : ICatalogsStrategy
    {
        private readonly AdresseeProxy _adresseeProxy;
        private readonly List<string> _headerList = new List<string>();
        public AdresseesCatalogStrategy(AdresseeProxy adresseeProxy)
        {
            _adresseeProxy = adresseeProxy;
        }

        public async Task<IEnumerable> GetAll()
        {
            var all = await _adresseeProxy.GetAdressees();
            return all;
        }

        public List<string> GetHeaders()
        {
            _headerList.Add("ID");
            _headerList.Add("Название");
            _headerList.Add("Телефон");
            _headerList.Add("Адрес");
            return _headerList;
        }
    }

    public class SchemesCatalogStrategy : ICatalogsStrategy
    {
        private readonly SchemeProxy _schemeProxy;
        private readonly List<string> _headerList = new List<string>();
        public SchemesCatalogStrategy(SchemeProxy schemeProxy)
        {
            _schemeProxy = schemeProxy;
        }

        public async Task<IEnumerable> GetAll()
        {
            var all = await _schemeProxy.GetSchemes();
            return all;
        }

        public List<string> GetHeaders()
        {
            _headerList.Add("ID");
            _headerList.Add("Название");
            return _headerList;
        }
    }

    public class ConfigurationsCatalogStrategy : ICatalogsStrategy
    {
        private readonly ConfigurationProxy _configurationProxy;
        private readonly List<string> _headerList = new List<string>();
        public ConfigurationsCatalogStrategy(ConfigurationProxy configurationProxy)
        {
            _configurationProxy = configurationProxy;
        }

        public async Task<IEnumerable> GetAll()
        {
            var all = await _configurationProxy.GetConfigurations();
            return all;
        }

        public List<string> GetHeaders()
        {
            _headerList.Add("ID");
            _headerList.Add("Название");
            _headerList.Add("Горячая клавиша");
            return _headerList;
        }
    }

    public class SkinTypesCatalogStrategy : ICatalogsStrategy
    {
        private readonly SkinTypeProxy _skinTypeProxy;
        private readonly List<string> _headerList = new List<string>();
        public SkinTypesCatalogStrategy(SkinTypeProxy skinTypeProxy)
        {
            _skinTypeProxy = skinTypeProxy;
        }

        public async Task<IEnumerable> GetAll()
        {
            var all = await _skinTypeProxy.GetSkinTypes();
            return all;
        }

        public List<string> GetHeaders()
        {
            _headerList.Add("ID");
            _headerList.Add("Название");
            _headerList.Add("Минимальный вес");
            _headerList.Add("Максимальный вес");
            _headerList.Add("Максималное кол-во шкур");
            return _headerList;
        }
    }

    public class ProvidersCatalogStrategy : ICatalogsStrategy
    {
        private readonly ProviderProxy _providerProxy;
        private readonly List<string> _headerList = new List<string>();
        public ProvidersCatalogStrategy(ProviderProxy providerProxy)
        {
            _providerProxy = providerProxy;
        }

        public async Task<IEnumerable> GetAll()
        {
            var all = await _providerProxy.GetAllProviders();
            return all;
        }

        public List<string> GetHeaders()
        {
            _headerList.Add("ID");
            _headerList.Add("Название");
            _headerList.Add("Телефон");
            _headerList.Add("Адрес");
            _headerList.Add("Скидка");
            return _headerList;
        }

        //public object Add(string name)
        //{
        //    var dep = new Departments { Department = name};
        //    Departments result = _controller.AddDepartment(dep);
        //    return result;
        //}

        //public bool Delete(string id)
        //{
        //    bool result = _controller.DeleteDepartment(id);
        //    return result;
        //}

        //public bool Change(string name, int id)
        //{
        //    Departments dep = new Departments {IdDepartment = id, Department = name};
        //    bool result = _controller.ChangeDepartment(dep);
        //    return result;
        //}
    }



}
