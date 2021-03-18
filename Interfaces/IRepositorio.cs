using System.Collections.Generic;

namespace DIO.series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Excluir (int id);
        int ProximoId();
        void Atualiza(int id, T entidade);
         
    }
}