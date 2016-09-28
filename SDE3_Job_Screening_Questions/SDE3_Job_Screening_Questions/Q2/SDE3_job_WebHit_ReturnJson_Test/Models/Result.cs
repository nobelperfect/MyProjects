using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Result : IEquatable<Result>
    {
        public string FirstName;
        public int HowManyVisit;
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Result);
        }
        public bool Equals(Result other)
        {
            if (other == null)
                return false;

            return this.FirstName.Equals(other.FirstName) &&
                (
                    object.ReferenceEquals(this.HowManyVisit, other.HowManyVisit) ||
                    this.HowManyVisit != null &&
                    this.HowManyVisit.Equals(other.HowManyVisit
                ));
        }
    }
}