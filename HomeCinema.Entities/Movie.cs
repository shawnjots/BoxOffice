using System;
using System.Collections.Generic;

namespace HomeCinema.Entities
{
    public class Movie : IEntityBase
    {
        public Movie()
        {
            Stocks = new List<Stock>();
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        private string director;
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private string writer;
        public string Writer
        {
            get { return writer; }
            set { writer = value; }
        }

        private string producer;
        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        private DateTime releaseDate;
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        private byte rating;
        public byte Rating
        {
            get { return rating; }
        }

        private string trailerURI;
        public string TrailerURI
        {
            get { return trailerURI; }
            set { trailerURI = value; }
        }

        public virtual ICollection<Stock> Stocks { get; set; }

    }
}