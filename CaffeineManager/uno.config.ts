import {defineConfig, presetWind3} from "unocss";

export default defineConfig({
    content: {
        filesystem: ["**/*.{html,js,ts,jsx,tsx,cs,razor,cshtml}"]
    },
    presets: [
        presetWind3({
            important: true
        })
    ]
})