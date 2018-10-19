using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
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

        private Face[] faceDetected; 

        //Creting consts to keep mines uri saved
        const string uri = "https://southcentralus.api.cognitive.microsoft.com/face/v1.0";
        const string uriFaceDetect = uri + "";
        const string uriFaceVerify = uri + "";
        const string key = "";

        public MainPage()
        {
            InitializeComponent();

            //Initialize connection with API
            _faceServiceClientDetect = new FaceServiceClient(key, uriFaceDetect);
            _faceServiceClientVerify = new FaceServiceClient(key, uriFaceVerify);
        }

        private async void takeFirstPicture(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void takeSecondPicture(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
