using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBDNRESTDemoCSharp;

namespace BBDNRESTDemoCSharp
{
    public class TermHelper
    {
        public static Term GenerateObject()
        {
            Term term = new Term();
            Availability availability = new Availability();
            Duration duration = new Duration();

            duration.type = "Continuous";

            availability.available = "Yes";
            availability.duration = duration;

            term.externalId = Constants.TERM_ID;
            term.description = Constants.TERM_DISPLAY;
            term.name = Constants.TERM_NAME;
            term.availability = availability;

            return term;
        }

    }
}
