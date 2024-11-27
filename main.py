import os
import sys

def crearCarpeta(nombre: str, carpeta: str):

    codigo_csharp_dat =  f"""using CapaEntidad.{carpeta};
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.{carpeta}
{{
    public class dat{nombre}
    {{
        private static readonly dat{nombre} _instancia = new dat{nombre}();

        public static dat{nombre} Instancia
        {{
            get {{ return _instancia; }}
        }}
    }}
}}"""
    codigo_csharp_ent =  f"""using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.{carpeta}
{{
    public class ent{nombre}
    {{
    }}
}}
        """
    codigo_csharp_log = f"""using CapaAccesoDatos.{carpeta};
using CapaEntidad.{carpeta};
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.{carpeta}
{{
    public class log{nombre}
    {{
        private static readonly log{nombre} _instancia = new log{nombre}();

        public static log{nombre} Instancia
        {{
            get {{ return _instancia; }}
        }}
    }}
}}"""


    
    carpeta1 = os.path.join("CapaAccesoDatos", carpeta)
    carpeta2 = os.path.join("CapaEntidad", carpeta)
    carpeta3 = os.path.join("CapaLogica", carpeta)
    
    if not os.path.exists(carpeta1):
        os.makedirs(carpeta1)
    if not os.path.exists(carpeta2):
        os.makedirs(carpeta2)
    if not os.path.exists(carpeta3):
        os.makedirs(carpeta3)
        
    ruta_archivo_dat = os.path.join(carpeta1, f"dat{nombre}.cs")
    ruta_archivo_ent = os.path.join(carpeta2, f"ent{nombre}.cs")
    ruta_archivo_log = os.path.join(carpeta3, f"log{nombre}.cs")
    
    with open(ruta_archivo_dat, 'w') as dat:
        dat.write(codigo_csharp_dat)
    with open(ruta_archivo_ent, 'w') as ent:
        ent.write(codigo_csharp_ent)
    with open(ruta_archivo_log, 'w') as log:
        log.write(codigo_csharp_log)
        
        

if len(sys.argv) < 3:
    print("pon dos parametros mrd :D")
    sys.exit(1)

nombre = sys.argv[1]
carpeta = sys.argv[2]

crearCarpeta(nombre, carpeta)
