using System;

namespace app_cadastro
{
    public class Series : BaseEntity
    {
        private Genre genre { get; set; }
        private string title { get; set; }
        private string describe { get; set; }
        private short year { get; set; }
        private bool deleted { get; set; }

        public Series(int id, Genre genre, string title, string describe, short year)
        {
            this.id = id;
            this.genre = genre;
            this.title = title;
            this.describe = describe;
            this.year = year;
            this.deleted = false;
        }

        public override string ToString()
        {
            string str = "";
            str += "ID: " + this.id;
            str += "Gênero: " + this.genre + Environment.NewLine;
            str += "Título: " + this.title + Environment.NewLine;
            str += "Descrição: " + this.describe + Environment.NewLine;
            str += "Ano: " + this.year;
            str += "Excluido: " + this.deleted + Environment.NewLine;
            return str;
        }

        public void delete()
        {
            this.deleted = true;
        }

        public int retornaID()
        {
            return this.id;
        }

        public string retornaTitulo()
        {
            return this.title;
        }
    }
}