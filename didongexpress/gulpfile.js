var gulp = require('gulp'),
    scss = require('gulp-ruby-sass'),
    postcss = require('gulp-postcss'),
    autoprefixer = require('autoprefixer'),
    notify = require('gulp-notify');

// styles task
var cssTask = gulp.task('css', function () {
    return scss('./Content/**/*.scss')        
        .pipe(postcss([autoprefixer({ browsers: ['last 2 versions'] })]))
        .pipe(gulp.dest(function (file) { return file.base; }))
        .pipe(notify({ message: 'css task completed' }));    
});

// js task

// images task

// watch
gulp.task('watch', function () {
    gulp.watch('./Content/**/*.scss', ['css']); // watch file `./Content/**/*.scss` and run task `css`
});