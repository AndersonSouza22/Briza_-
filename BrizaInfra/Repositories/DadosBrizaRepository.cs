using System;
using System.Collections.Generic;
using System.Text;
using BrizaInfra.Datasource;
using BrizaInfra.Generics;
using DomainBriza;
using DomainBriza.Services;

namespace BrizaInfra.Repositories
{
    public class DadosBrizaRepository : GenericData<DadosBriza> , IServiceDadosBriza
    {
        public DadosBrizaRepository(BrizaContext brizaContext): base(brizaContext)
        {

        }

        // metodos 
    }
}
    