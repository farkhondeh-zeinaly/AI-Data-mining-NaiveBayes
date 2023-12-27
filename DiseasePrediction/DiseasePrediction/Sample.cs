using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiseasePrediction
{
    public class Sample
    {
        public string SampleNumber { get; set; }
        public List<GeneExpression> GeneValues { get; set; }
        public string ClassName { get; set; }
    }
}
