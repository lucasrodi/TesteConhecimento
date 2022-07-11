import axios from "axios";
import { useEffect, useState } from "react";
export function PostFilme<T = unknown>(url: string, nome: string, duracao: string, genero: string) {
    const [erro, setErro] = useState<T | null>(null)
    useEffect(() => {
        axios.post(url, {
            nome,
            duracao,
            genero
        })
            .catch(er => setErro(er));
    }, [url, nome, duracao, genero])
    return { erro }

}
