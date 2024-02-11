using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Katena.Domain.Entities
{
    public class QuestionBase
    {
        public virtual Question Quest { get; set; }
    }
}