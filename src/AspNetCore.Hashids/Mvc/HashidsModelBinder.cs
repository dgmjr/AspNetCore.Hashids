using HashidsNet;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Hashids.Mvc
{
    public class HashidsModelBinder(IHashids hashids) : IModelBinder
    {
        private readonly IHashids _hashids = hashids ?? throw new System.ArgumentNullException(nameof(hashids));

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext is null)
            {
                throw new System.ArgumentNullException(nameof(bindingContext));
            }

            var modelName = bindingContext.ModelName;

            var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

            var value = valueProviderResult.FirstValue;

            if (string.IsNullOrEmpty(value))
            {
                return Task.CompletedTask;
            }

            var ids = _hashids.Decode(value);

            if (ids.Length == 0)
            {
                return Task.CompletedTask;
            }

            bindingContext.Result = ModelBindingResult.Success(ids[0]);

            return Task.CompletedTask;
        }
    }
}
