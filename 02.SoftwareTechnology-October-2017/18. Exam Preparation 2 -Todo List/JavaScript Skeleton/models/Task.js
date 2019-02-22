const mongoose = require('mongoose');

let taskSchema = mongoose.Schema({
    title: {type: 'string', require: 'true'},
    comments: {type: 'string', require: 'true'}
});

let Task = mongoose.model('Task', taskSchema);

module.exports = Task;