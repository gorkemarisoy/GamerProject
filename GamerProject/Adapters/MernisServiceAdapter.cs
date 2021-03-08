using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Abstract;
using GamerProject.Entities;
using MernisServiceReference;

namespace GamerProject.Adapters
{
    public class MernisServiceAdapter:IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                    (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NationalIdNumber), gamer.FirstName, gamer.LastName, gamer.BirthDate.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
