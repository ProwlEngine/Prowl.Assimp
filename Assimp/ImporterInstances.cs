using Assimp.Formats.Obj;
using Assimp.Formats.Ply;
using Assimp.Formats.Stl;

namespace Assimp
{
    public static class ImporterInstances
    {
        public static List<BaseImporter> GetImporterInstanceList()
        {
            var list = new List<BaseImporter>();

            if (!ASSIMP.BUILD.NO.STL_IMPORTER) list.Add(new STLImporter());
            if (!ASSIMP.BUILD.NO.OBJ_IMPORTER) list.Add(new ObjFileImporter());
            if (!ASSIMP.BUILD.NO.PLY_IMPORTER) list.Add(new PlyLoader());
            //if (!ASSIMP.BUILD.NO.COLLADA_IMPORTER) list.Add(new ColladaLoader());
            //if (!ASSIMP.BUILD.NO.ASSBIN_IMPORTER) list.Add(new AssbinLoader());
            //if (!ASSIMP.BUILD.NO.MD2_IMPORTER) list.Add(new MD2Importer());

            return list;
        }

        public static List<BaseProcess> GetPostProcessingStepInstanceList()
        {
            var list = new List<BaseProcess>
            {
                new TriangulateProcess(),
                new LimitBoneWeightsProcess(),
                new MakeLeftHandedProcess(),
                new FlipUVsProcess(),
                new FlipWindingOrderProcess(),
                new GenFaceNormalsProcess(),
                new GenVertexNormalsProcess(), 
            };

            return list;
        }
    }
}
