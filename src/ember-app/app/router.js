import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-12345-должность-l');
  this.route('i-i-s-12345-должность-e',
  { path: 'i-i-s-12345-должность-e/:id' });
  this.route('i-i-s-12345-должность-e.new',
  { path: 'i-i-s-12345-должность-e/new' });
  this.route('i-i-s-12345-отчет-о-сервере-l');
  this.route('i-i-s-12345-отчет-о-сервере-e',
  { path: 'i-i-s-12345-отчет-о-сервере-e/:id' });
  this.route('i-i-s-12345-отчет-о-сервере-e.new',
  { path: 'i-i-s-12345-отчет-о-сервере-e/new' });
  this.route('i-i-s-12345-расположение-l');
  this.route('i-i-s-12345-расположение-e',
  { path: 'i-i-s-12345-расположение-e/:id' });
  this.route('i-i-s-12345-расположение-e.new',
  { path: 'i-i-s-12345-расположение-e/new' });
  this.route('i-i-s-12345-сенсоры-l');
  this.route('i-i-s-12345-сенсоры-e',
  { path: 'i-i-s-12345-сенсоры-e/:id' });
  this.route('i-i-s-12345-сенсоры-e.new',
  { path: 'i-i-s-12345-сенсоры-e/new' });
  this.route('i-i-s-12345-серверная-l');
  this.route('i-i-s-12345-серверная-e',
  { path: 'i-i-s-12345-серверная-e/:id' });
  this.route('i-i-s-12345-серверная-e.new',
  { path: 'i-i-s-12345-серверная-e/new' });
  this.route('i-i-s-12345-сотрудник-l');
  this.route('i-i-s-12345-сотрудник-e',
  { path: 'i-i-s-12345-сотрудник-e/:id' });
  this.route('i-i-s-12345-сотрудник-e.new',
  { path: 'i-i-s-12345-сотрудник-e/new' });
});

export default Router;
