namespace App1.Test
{
	public class Tests
	{
		private MainViewModel _viewModel;

		[SetUp]
		public void Setup()
		{
			_viewModel = new MainViewModel();
		}

		[Test]
		public void InitNameCommand_Execute_SetsNameProperty()
		{
			// Arrange
			const string name = "Bruce Wayne";

			// Act
			_viewModel.InitNameCommand.Execute(name);

			// Assert
			Assert.That(_viewModel.Name, Is.EqualTo(name), "Expected name to be set");
		}
	}
}