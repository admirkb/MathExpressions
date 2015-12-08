using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;
using KBMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathExpressions.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {

        public RelayCommand<string> SetCompany { get; private set; }
     

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            //this.MathParser = mathParser;
            Heading = "Expression Evaluator";

            SetCompany = new RelayCommand<string>((s) => SetCompanyClicked(s));

            TextBlockInputMVVM = "( 5 + 5 ) * (3 + 2 ) - 1";
        }

        #region ITextViewModel Members

        /// <summary>
        /// Gets or sets the label contnet.
        /// </summary>
        /// <value>The label contnet.</value>


        private string _heading;
        public string Heading
        {
            get { return _heading; }
            set
            {
                _heading = value;
                RaisePropertyChanged("Heading");

            }
        }
        private string _textBlockResultMVVM;
        public string TextBlockResultMVVM
        {
            get { return _textBlockResultMVVM; }
            set
            {
                _textBlockResultMVVM = value;
                RaisePropertyChanged("TextBlockResultMVVM");

            }
        }

        private string _textBlockInputMVVM;
        public string TextBlockInputMVVM
        {
            get { return _textBlockInputMVVM; }
            set
            {
                _textBlockInputMVVM = value;
                RaisePropertyChanged("TextBlockInputMVVM");

            }
        }
        #endregion

        private void SetCompanyClicked(string s)
        {

            var mathParser = new MathParser('.');
            //var input = "(12 + 12) - 1";
            var input = _textBlockInputMVVM;
            //var output = 23d;

            TextBlockResultMVVM = mathParser.Parse(input).ToString();

        }
    }
}
