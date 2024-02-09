using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
	//Публичный интерфейс заполнения страниц сайта
	public interface ITextField
	{
		IQueryable<TextField> GetTextFields();
		TextField GetTextFieldById(Guid id);
		TextField GetTextFieldByCodeWord(string codeWord);
		void SaveTextField(TextField entity);
		void DeleteTextField(Guid id);
	}
}
