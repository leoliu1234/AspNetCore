module.exports = {
    entry: './AspNetCore/wwwroot/public/js/index.js',
    output: {
      filename: './AspNetCore/wwwroot/public/js/bundle.js'
    },
    module: {
        rules: [
          { test: /\.js$/, exclude: /node_modules/, loader: "babel-loader" }
        ]
      }
  };