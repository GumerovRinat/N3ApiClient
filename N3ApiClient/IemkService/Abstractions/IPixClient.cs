namespace N3ApiClient.IemkService.Abstractions
{
    /// <summary>
    /// Основной интерфейс клиента
    /// </summary>
    public interface IPixClient
    {
        /// <summary>
        /// Выполнение операции сервиса Обмена данными пациентов
        /// </summary>
        /// <param name="operation">Операция сервиса</param>
        /// <returns>Результат выполнения операции</returns>
        IOperationResult ExecuteOperation(IPixClientOperation operation);
    }
}
