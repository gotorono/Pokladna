using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna_Pavel
{
    public class JsonRepos : IRepos
    {
        public List<PokladniZaznam> NactiVse()
        {
            throw new NotImplementedException();
        }

        public PokladniZaznam NactiZaznam(int idZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }
    }
}
