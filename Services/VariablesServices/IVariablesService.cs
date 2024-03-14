namespace StarFitApi.Services.VariablesServices;

public interface IVariablesService
{
    public Task<string> GetVariable(string property);
    public Task<string> PatchVariable(string property, string value);
}