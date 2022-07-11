import axios from "axios";
import { useEffect, useState } from "react";

export function GetFilme<T = unknown>(url: string) {
    const [data, setData] = useState<T | null>();
    const [erro, setErro] = useState<T | null>(null)

    useEffect(() => {
        axios.get(url)
            .then(resposta => { setData(resposta.data) })
            .catch(er => setErro(er))

    }, [url])
    return { data, erro }
}