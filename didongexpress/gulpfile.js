var gulp = require('gulp'),
    scss = require('gulp-ruby-sass'),
    postcss = require('gulp-postcss'),
    autoprefixer = require('autoprefixer'),
    notify = require('gulp-notify');

// styles task
var cssTask = gulp.task('css', function () {
    return scss('./Content/styles/styles.scss')
        .pipe(postcss([autoprefixer({ browsers: ['last 2 versions'] })]))
        .pipe(gulp.dest('./Content/styles/'))
        .pipe(notify({ message: 'css task completed' }));
});

// js task

// images task

// watch
gulp.task('watch', function () {
    gulp.watch('./Content/styles/styles.scss', ['css']); // watch file `./Content/styles/styles.scss` and run task `css`
});