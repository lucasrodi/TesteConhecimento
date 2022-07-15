import axios from "axios";
import { useEffect, useState } from "react";
export function PutFilme<T = unknown>(url: string) {
    const [erro, setErro] = useState<T | null>(null)
    useEffect(() => {
        axios.put(url)
            .catch(er => setErro(er));
    }, [url])
    return { erro }

}