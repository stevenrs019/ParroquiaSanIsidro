using SistemaWebParroquia.Models;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SistemaWebParroquia.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace SistemaWebParroquia.Service
{
    public class ServiceCosmosDb
    {
        //todo funciona con un client de cosmos
        //hemos creado una cuenta en un endpoint llamada cochescls
        DocumentClient client;
        String bbdd;
        String collection;
        public ServiceCosmosDb(IConfiguration configuration)
        {
            String endpoint = configuration["CosmosDb:endPoint"];
            String primarykey = configuration["CosmosDb:primaryKey"];
            this.bbdd = "Personas BBDD";
            this.collection = "PersonasCollection";
            this.client = new DocumentClient(new Uri(endpoint), primarykey);
        }
        public async Task CrearBbddPersonaAsync()
        {
            Microsoft.Azure.Documents.Database bbdd = new Microsoft.Azure.Documents.Database() { Id = this.bbdd };
            await this.client.CreateDatabaseAsync(bbdd);
        }
        public async Task CrearColeccionPersonasAsync()
        {
            DocumentCollection coleccion = new DocumentCollection() { Id = this.collection };
            //Factory es para recuperar de cosmos la base de datos
            await this.client.CreateDocumentCollectionAsync(UriFactory.CreateDatabaseUri(this.bbdd), coleccion);
        }
        public async Task InsertarPersona(Persona Persona)
        {
            //recuperamos la URI para la coleccion donde ira el vehiculo
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection);
            await this.client.CreateDocumentAsync(uri, Persona);
        }
        public List<Persona> GetPersonas()
        {
            // debemos indicar el numero de Personas a recuperar
            FeedOptions options = new FeedOptions() { MaxItemCount = -1 };
            String sql = "SELECT * FROM C"; // a todo lo llama 'c'
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection);
            IQueryable<Persona> consulta = this.client.CreateDocumentQuery<Persona>(uri, sql, options);
            return consulta.ToList();
        }

        public async Task<Persona> FindPersonaAsyn(String id)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, id);
            //lo que recupera es de la clase document

            Microsoft.Azure.Documents.Document document = await this.client.ReadDocumentAsync(uri);
            //este documento es un stream
            //guardamos en el objeto stream en memoria lo que recuperamos, para luego leerlo en memoria
            MemoryStream memory = new MemoryStream();
            using (var stream = new StreamReader(memory))
            {
                document.SaveTo(memory);
                memory.Position = 0;
                //deserializamos con JsonConvert
                Persona Persona = JsonConvert.DeserializeObject<Persona>(await stream.ReadToEndAsync());
                return Persona;
            }
        }
        public async Task ModificarPersona(Persona Persona)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, Persona.Id);
            await this.client.ReplaceDocumentAsync(uri, Persona);
        }

        public async Task EliminarPersona(String id)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, id);
            await this.client.DeleteDocumentAsync(uri);
        }

        public List<Persona> BuscarPersona(String id)
        {
            FeedOptions options = new FeedOptions() { MaxItemCount = -1 };
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection);
            String sql = "select * from c where c.Id='" + id + "'";
            IQueryable<Persona> query = this.client.CreateDocumentQuery<Persona>(uri, sql, options);
            IQueryable<Persona> querylambda = this.client.CreateDocumentQuery<Persona>(uri, options)
                    .Where(z => z.Id == id);

            return query.ToList();
        }

        public List<Persona> CrearPersona()
        {
            List<Persona> Personas = new List<Persona>() {
            new Persona
            {
                Id="1",Nombre="Steven", Apellido1="Rodríguez",
                Apellido2= "Solano"
            },
             new Persona
            {
               Id="2",Nombre="Roberto", Apellido1="Monzón",
                Apellido2= "Trujillo"
            }
            };
            return Personas;

            //}
        }
    }

}

