using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BankApi.Logic.ApiLogic
{
    public class ApiDataAccess : IApiDataAccess
    {
        public string GetDataFromApi(string apiUrl)
        {
            HttpWebResponse response = null;

            string readData = String.Empty;

            WebRequest request = WebRequest.Create(apiUrl);            

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }

            using (Stream stream = response.GetResponseStream())
            using (StreamReader sr = new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet)))
            {
                readData = sr.ReadToEnd();
            }

            switch (response.StatusCode) // TODO: add logic  
            {
                case HttpStatusCode.OK:        
                    break;
                case HttpStatusCode.Forbidden: 
                    break;
                case HttpStatusCode.NotFound:  
                    break;
                case HttpStatusCode.Moved:    
                    break;
                default:
                    break;
            }

            return readData;
        }
    }
}
