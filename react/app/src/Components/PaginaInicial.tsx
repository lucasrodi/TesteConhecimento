import { Link } from "react-router-dom";
import './index.css'


export function PaginaInicial() {
    return (
        <div className="container">
            <Link className="link" to="TodosOsFilmes">Ver todos os Filmes</Link>
            <Link className="link" to="AdicionarFilme">Adicionar Filme</Link>
            <Link className="link" to="BuscarFilme">Buscar Filme</Link>
        </div>
    );
}