using System;
using Raven.Client.Document;
using Raven.Client.Linq;
using System.Linq;
using System.Collections.Generic;

namespace NancyTests
{
    public class TodosRepository
    {
        DocumentStore store;

        public TodosRepository()
        {
            this.store = new DocumentStore
            {
                Url = "https://ibis.ravenhq.com/databases/brenocferreira-TesteTDC",
                ApiKey = "6eeaa59c-f307-4cf9-bfce-2aaeadb98e5a"
            };
            store.EnlistInDistributedTransactions = false;
            store.JsonRequestFactory.DisableRequestCompression = true;

            store.Initialize();
        }

        public void Store(TodoItem item){
            using (var session = this.store.OpenSession())
            {
                session.Store(item);
                session.SaveChanges();
            }
        }

        public IEnumerable<TodoItem> Get(){
            using (var session = this.store.OpenSession())
            {
                return session.Query<TodoItem>().ToList();
            }
        }

        public TodoItem GetById(int id){
            using (var session = this.store.OpenSession())
            {
                return session.Load<TodoItem>(id);
            }
        }

        public void Delete(int id){
            using (var session = this.store.OpenSession())
            {
                var item = session.Load<TodoItem>(id);
                session.Delete(item);
                session.SaveChanges();
            }
        }
    }
}

