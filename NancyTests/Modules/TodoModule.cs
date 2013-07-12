using System;
using System.Collections.Generic;
using System.Linq;
using Nancy.ModelBinding;

namespace NancyTests
{
    public class TodoModule : Nancy.NancyModule
    {
        TodosRepository repository;

        public TodoModule()
        {
            this.repository = new TodosRepository();

            Get["/todos"] = _ => this.repository.Get();

            Get["/todos/{id}"] = _ => { 
                string id = _.id;
                return this.repository.GetById(int.Parse(id));
            };

            Post["/todos"] = _ => {
                var todoItem = this.Bind<TodoItem>();
                this.repository.Store(todoItem);
                return todoItem;
            };

            Put["/todos/{id}"] = _ => {
                var todoItem = this.Bind<TodoItem>();

                this.repository.Store(todoItem);

                return todoItem;
            };

            Delete["/todos/{id}"] = _ => { 
                string id = _.id;
                this.repository.Delete(int.Parse(id));

                return Nancy.HttpStatusCode.OK;
            };
        }
    }
}

