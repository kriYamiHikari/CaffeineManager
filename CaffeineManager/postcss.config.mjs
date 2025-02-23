import UnoCSS from "@unocss/postcss";
import cssnano from "cssnano";

export default {
    plugins:[
        UnoCSS(),
        cssnano({
            preset:"default"
        })
    ]
}