using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClovaAPI.Model
{
    public class FaceElement
    {
        public FaceElement()
        {
            initialize(); 
        }

        private void initialize()
        {
            positionX = 0;
            positionY = 0;
            width = 0;
            height = 0;

            gender = "male";
            genderConfidence = 0.0f;

            ageMin = 0;
            ageMax = 0;
            ageConfidence = 0.0f;

            emotion = "unknown";
            emotionConfidence = 0.0f;

            facePose = "unknown";
            facePoseConfidence = 0.0f;
        }

        private int positionX;
        private int positionY;
        private int width;
        private int height;

        private string gender;
        private float genderConfidence;

        private int ageMin;
        private int ageMax;
        private float ageConfidence;

        private string emotion;
        private float emotionConfidence;

        private string facePose;
        private float facePoseConfidence;
        
        public int PositionX { get { return positionX; } set { positionX = value; } }
        public int PositionY { get { return positionY; } set { positionY = value; } }
        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }

        public string Gender { get { return gender;} set { gender = value; } }
        public float GenderConfidence { get { return genderConfidence; } set { genderConfidence = value; } }

        public void SetAge(string _ageValue)
        {
            string ageMinString = _ageValue.Substring(0, 2);
            string ageMaxString = _ageValue.Substring(_ageValue.Length - 2);

            ageMin = int.Parse(ageMinString);
            ageMax = int.Parse(ageMaxString);
        }
        public int AgeMin { get { return ageMin; } }
        public int AgeMax { get { return ageMax; } }
        public float AgeConfidence { get { return ageConfidence; } set { ageConfidence = value; } }

        public string Emotions { get { return emotion; } set { emotion = value; } }
        public float EmotionsConfidence { get { return emotionConfidence; } set { emotionConfidence = value; } }

        public string FacePose { get { return facePose; } set { facePose = value; } }
        public float FacePoseConfidence { get { return facePoseConfidence; } set { facePoseConfidence = value; } }
    }
}
