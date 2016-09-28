using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Hit : IEquatable<Hit>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }


        public override bool Equals(object obj)
        {
            return this.Equals(obj as Hit);
        }
        public bool Equals(Hit other)
        {
            if (other == null)
                return false;

            return this.Url.Equals(other.Url) &&
                (
                    object.ReferenceEquals(this.Date, other.Date) ||
                    this.Date != null &&
                    this.Date.Equals(other.Date
                )) &&
                (
                    object.ReferenceEquals(this.UserId, other.UserId) ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId
                ));
        }
    }
}