using prmToolkit.NotificationPattern;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;

namespace Library.Class.Models
{
    [Table("TBL_LOG")]
    public class Log : Notifiable
    {
        private const string INSERT_ACTION = "Adicionado";
        private const string UPDATE_ACTION = "Alterado";
        private const string DELETE_ACTION = "Deletado";

        public Log()
        {
            this.Data = DateTime.Now;
        }
        [Key]
        public int CodigoLog { get;private set; }
        
        public string Acao { get; private set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(500)]
        public string Campo { get; private set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(500)]
        public string NovoCampo { get; private set; }

        public DateTime Data { get; private set; }

        public static Log CreateInsertLog(object newEntity)
        {
            Log log = new Log();

            log.Acao = INSERT_ACTION;
            log.Campo = null;
            log.NovoCampo = Serialize(newEntity);

            return log;
        }

        public static Log CreateDeleteLog(object newEntity)
        {
            Log log = new Log();

            log.Acao = DELETE_ACTION;
            log.Campo = Serialize(newEntity);
            log.NovoCampo = null;

            return log;
        }

        public static Log CreateUpdateLog(object originalEntity, object newEntity)
        {

            Log log = new Log();

            log.Acao = UPDATE_ACTION;
            log.Campo = Serialize(originalEntity);
            log.NovoCampo = Serialize(newEntity);

            return log;
        }

        private static string Serialize(object obj)
        {

            return SerializeJson(obj);
            //return SerializeXml(obj);
        }

        private static string SerializeXml(object obj)
        {

            XmlSerializer xs = new XmlSerializer(obj.GetType());
            using (MemoryStream buffer = new MemoryStream())
            {
                xs.Serialize(buffer, obj);
                return ASCIIEncoding.ASCII.GetString(buffer.ToArray());
            }
        }

        private static string SerializeJson(object obj)
        {

            //using (MemoryStream buffer = new MemoryStream())
            //{
            //    DataContractJsonSerializer ser = new DataContractJsonSerializer(obj.GetType());
            //    ser.WriteObject(buffer, obj);
            //    return ASCIIEncoding.ASCII.GetString(buffer.ToArray());
            //}
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
    }
}
