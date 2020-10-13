﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna_Pavel
{
    public interface IRepos
    {
        List<PokladniZaznam> NactiVse();
        PokladniZaznam NactiZaznam(int idZaznam);
        PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam);
        void UpravZaznam(PokladniZaznam pokladniZaznam);
        void SmazZaznam(PokladniZaznam pokladniZaznam);

    }
}
