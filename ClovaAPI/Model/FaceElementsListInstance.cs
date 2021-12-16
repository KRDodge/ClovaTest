using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClovaAPI.Model
{
    public class FaceElementsListInstance
    {
        private static FaceElementsListInstance instance;

        private List<FaceElement> faces;

        public FaceElementsListInstance()
        {
            faces = new List<FaceElement>();
        }

        public static FaceElementsListInstance GetInstance()
        {
            if((instance == null))
                instance = new FaceElementsListInstance();

            return instance;
        }

        public void AddFaceElement(FaceElement _face)
        {
            faces.Add(_face);
        }

        public List<FaceElement> GetFaceElements()
        {
            return faces;
        }
    }
}
