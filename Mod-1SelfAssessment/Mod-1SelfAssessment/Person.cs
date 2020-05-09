using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Mod_1SelfAssessment
{
    abstract class Person : IDisposable
    {
        private bool disposed = false;

        private StreamWriter streamWriter;

        public static int id = 1;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }

        //constructor
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
            this.Id = id++;
            this.streamWriter = new StreamWriter(name + ".txt", false);
        }

        public virtual string ToString()
        {
            return $"Id ={this.Id}, " +
                $"Name={this.Name}, " +
                $"Address={this.Address}";
        }

        public void Dispose()
        {
            Console.WriteLine($"Public Dispose called for Person::Id={this.Id}");
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected abstract string GetSerializedObject();

        protected void Persist()
        {
            this.streamWriter.WriteLine(this.GetSerializedObject());
        }

        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine($"Dispose called for Person::Id={this.Id}");
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.streamWriter.Dispose();
            }

            // free unmanaged resources
            this.disposed = true;
        }

        ~Person()
        {
            this.Dispose(false);
        }
    }
}