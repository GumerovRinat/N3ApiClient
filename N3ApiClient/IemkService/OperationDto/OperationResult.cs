using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.Exceptions;

namespace N3ApiClient.IemkService.OperationDto
{
    public class OperationResult : IOperationResult
    {
        private bool _success;
        private NetrikaClientException _exception;
        private object _operationResult;

        /// <summary>
        /// Вовзращает флаг успешности выполнения операции
        /// </summary>
        /// <returns></returns>
        public bool IsSuccess()
        {
            return _success;
        }

        /// <summary>
        /// Возвращает ошибку при выполнении операции
        /// </summary>
        /// <returns></returns>
        public NetrikaClientException GetException()
        {
            return _exception;
        }

        /// <summary>
        /// Устанавливает флаг успешности выполнения операции
        /// </summary>
        /// <param name="success"></param>
        public IOperationResult SetSuccess(bool success)
        {
            _success= success;
            return this;
        }

        /// <summary>
        /// Устанавливает ошибку операции
        /// </summary>
        /// <param name="exception"></param>
        public IOperationResult SetException(object exception)
        {
            _exception = new NetrikaClientException(exception);
            return this;
        }

        /// <summary>
        /// Устанавливает ошибку операции
        /// </summary>
        /// <param name="exception"></param>
        public IOperationResult SetExceptionMessage(string exceptionMessage)
        {
            _exception = new NetrikaClientException(exceptionMessage);
            return this;
        }

        /// <summary>
        /// Возвращает объект полученный в результате выполнения операции
        /// </summary>
        /// <returns></returns>
        public T GetResult<T>()
        {
            return (T)_operationResult;
        }

        /// <summary>
        /// Устанавливает объект полученный в результате выполнения операции
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public IOperationResult SetResult(object result)
        {
            _operationResult = result;
            return this;
        }
    }
}
