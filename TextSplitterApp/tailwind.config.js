/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./Views/**/*.{cshtml,html,js}"],
    theme: {
        extend: {
            fontFamily: {
                'site': ["\"Jersey 15\"", "sans-serif",]
            }
        },
    },
    plugins: [],
}

