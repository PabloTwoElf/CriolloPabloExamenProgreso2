using CriolloPabloExamenProgreso2.Interfaces;
using CriolloPabloExamenProgreso2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriolloPabloExamenProgreso2.Reposities
{
    public class Pcriollo_RepositoryRecarga : ICriolloRecarga

    {

        public bool CreateRecarga(PCriolloRecarga recarga)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(recarga);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteRecarga(string numero)
        {
            throw new NotImplementedException();
        }

        public PCriolloRecarga GetRecarga(string numero)
        {
            PCriolloRecarga recarga = new PCriolloRecarga();
            if (File.Exists(_fileName))
            {
                string josn_data = File.ReadAllText(_fileName);
                recarga = JsonConvert.DeserializeObject<PCriolloRecarga>(josn_data);
            }
            return recarga;
        }

        public bool UpdateRecarga(ICriolloRecarga recarga)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRecarga(PCriolloRecarga recarga)
        {
            throw new NotImplementedException();
        }

        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "PCriollo.txt");


    }
}
