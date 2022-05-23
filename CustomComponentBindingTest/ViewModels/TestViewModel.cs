using System;
namespace CustomComponentBindingTest.ViewModels {
    public class TestViewModel : BaseViewModel {
        public TestViewModel() {
            testNumber = new Random().Next();
        }

        private int testNumber;
        public int TestNumber {
            get => testNumber;
            set => SetProperty(ref testNumber, value);
        }
    }
}
