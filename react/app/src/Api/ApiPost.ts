import axios from "axios";
import { useNavigate } from "react-router-dom";
import { useEffect, useState } from "react";
export function PostFilme<T = unknown>(url: string) {
    const [erro, setErro] = useState<T>()
    let navigate = useNavigate();
    useEffect(() => {
        axios.post(url)
            .then(() => {
                navigate("/")
            })
            .catch(er => setErro(er));
    }, [url, navigate])
    return { erro }

}
