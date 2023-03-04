using System;
namespace Navtest.ViewModels
{
	public class PickerPageViewModel : BindableObject
	{
        private void BoolHelper(int i)
        {
            switch (i)
            {
                case 1:
                    Check1 = true;
                   
                    break;
                case 2:
                    Check1 = false;
                    Check3 = false;
                    Check4 = false;
                    Check2 = true;
                    break;
                case 3:
                    Check1 = false;
                    Check2 = false;
                    Check3 = true;
                    Check4 = false;
                    break;
                case 4:
                    Check1 = false;
                    Check4 = true;
                    Check3 = false;
                    Check2 = false;
                     break;
            }
        }
        #region props
        private bool _check1, _check2, _check3, _check4;

        public bool Check1 { get =>_check1; set
            {
                _check1 = value;OnPropertyChanged();

                if (_check1)
                {
                    Check2 = false;
                    Check3 = false;
                    Check4 = false;
                }

            } }
        public bool Check2 { get => _check2; set
            {
                _check2 = value; OnPropertyChanged();
                if (_check2)
                {
                    Check1 = false;
                    Check3 = false;
                    Check4 = false;
                }
            } }
        public bool Check3 { get => _check3; set
            {
                _check3 = value; OnPropertyChanged();
                if (_check3)
                {
                    Check2 = false;
                    Check1 = false;
                    Check4 = false;
                }
            } }
        public bool Check4 { get => _check4; set
            {
                _check4 = value; OnPropertyChanged();
                if (_check4)
                {
                    Check2 = false;
                    Check3 = false;
                    Check1 = false;
                }
            } }

           #endregion
        public PickerPageViewModel()
		{
            Check1 = true;
            Check2 = false;
            Check3 = false;
            Check4 = false;
        }
	}
}

