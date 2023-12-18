import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-12345-должность', 'Unit | Model | i-i-s-12345-должность', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-12345-должность',
    'model:i-i-s-12345-контроллер',
    'model:i-i-s-12345-отчет-о-сервере',
    'model:i-i-s-12345-расположение',
    'model:i-i-s-12345-сенсоры',
    'model:i-i-s-12345-серверная',
    'model:i-i-s-12345-сотрудник',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
