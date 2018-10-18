using Microsoft.ProjectOxford.Face;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace face_compare
{
    public partial class MainPage : ContentPage
    {
        private readonly IFaceServiceClient _faceServiceClientDetect;
        private readonly IFaceServiceClient _faceServiceClientVerify;

        //Creting consts to keep mines uri saved
        const string uriFaceDetect = "";
        const string uriFaceVerify = "";
        const string key = "";

        public MainPage()
        {
            InitializeComponent();

            //Initialize connection with API
            _faceServiceClientDetect = new FaceServiceClient(key, uriFaceDetect);
            _faceServiceClientVerify = new FaceServiceClient(key, uriFaceVerify);
        }
    }
}
