import axios from "axios";

export default axios.create({
    baseURL: "https://localhost:7241/Api/Filme/"
})