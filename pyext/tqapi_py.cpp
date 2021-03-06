#include "tqapi_py.h"
#include "tquant_api.h"

using namespace tquant::api;

PyObject* _wrap_set_params(PyObject* self, PyObject *args, PyObject* kwargs);

void call_callback(PyObject* callback, const char* evt, PyObject* data)
{
    PyObject* arg = Py_BuildValue("sN", evt, data);

    PyObject* result = PyObject_CallObject(callback, arg);

    if (PyErr_Occurred() != nullptr) {
        PyErr_Print();
        PyErr_Clear();
    }

    Py_XDECREF(result);
    Py_XDECREF(arg);
}

static PyMethodDef tqapi_methods[] = {
    { (char *)"tapi_create",                (PyCFunction)_wrap_tapi_create,                 METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_destroy",               (PyCFunction)_wrap_tapi_destroy,                METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_place_order",           (PyCFunction)_wrap_tapi_place_order,            METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_cancel_order",          (PyCFunction)_wrap_tapi_cancel_order,           METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_query_orders",          (PyCFunction)_wrap_tapi_query_orders,           METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_query_trades",          (PyCFunction)_wrap_tapi_query_trades,           METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_query_positions",       (PyCFunction)_wrap_tapi_query_positions,        METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_query_balance",         (PyCFunction)_wrap_tapi_query_balance,          METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_set_callback",          (PyCFunction)_wrap_tapi_set_callback,           METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_query",                 (PyCFunction)_wrap_tapi_query,                  METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tapi_query_account_status",  (PyCFunction)_wrap_tapi_query_account_status,   METH_KEYWORDS | METH_VARARGS, NULL },

    { (char *)"dapi_create",                (PyCFunction)_wrap_dapi_create,                 METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"dapi_destroy",               (PyCFunction)_wrap_dapi_destroy,                METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"dapi_set_callback",          (PyCFunction)_wrap_dapi_set_callback,           METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"dapi_subscribe",             (PyCFunction)_wrap_dapi_subscribe,              METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"dapi_unsubscribe",           (PyCFunction)_wrap_dapi_unsubscribe,            METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"dapi_quote",                 (PyCFunction)_wrap_dapi_quote,                  METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"dapi_bar",                   (PyCFunction)_wrap_dapi_bar,                    METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"dapi_tick",                  (PyCFunction)_wrap_dapi_tick,                   METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"dapi_dailybar",              (PyCFunction)_wrap_dapi_dailybar,               METH_KEYWORDS | METH_VARARGS, NULL },

    { (char *)"set_params",                 (PyCFunction)_wrap_set_params,                  METH_KEYWORDS | METH_VARARGS, NULL },

    { (char *)"tqs_sc_trading_day",         (PyCFunction)_wrap_tqs_sc_trading_day,          METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_cur_time",            (PyCFunction)_wrap_tqs_sc_cur_time,             METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_post_event",          (PyCFunction)_wrap_tqs_sc_post_event,           METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_set_timer",           (PyCFunction)_wrap_tqs_sc_set_timer,            METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_kill_timer",          (PyCFunction)_wrap_tqs_sc_kill_timer,           METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_dapi_get",            (PyCFunction)_wrap_tqs_sc_dapi_get,             METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_dapi_put",            (PyCFunction)_wrap_tqs_sc_dapi_put,             METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_tapi_get",            (PyCFunction)_wrap_tqs_sc_tapi_get,             METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_tapi_put",            (PyCFunction)_wrap_tqs_sc_tapi_put,             METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_log",                 (PyCFunction)_wrap_tqs_sc_log,                  METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_get_properties",      (PyCFunction)_wrap_tqs_sc_get_properties,       METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_get_property",        (PyCFunction)_wrap_tqs_sc_get_property,         METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_mode",                (PyCFunction)_wrap_tqs_sc_mode,                 METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_sc_stop",                (PyCFunction)_wrap_tqs_sc_stop,                 METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_bt_run",                 (PyCFunction)_wrap_tqs_bt_run,                  METH_KEYWORDS | METH_VARARGS, NULL },
    { (char *)"tqs_rt_run",                 (PyCFunction)_wrap_tqs_rt_run,                  METH_KEYWORDS | METH_VARARGS, NULL },

    { NULL, NULL, 0, NULL }
};


struct module_tqapi {
    int foo;
};

// #if PY_MAJOR_VERSION >= 3
// #define GETSTATE(m) ((struct module_tqapi*)PyModule_GetState(m))
// #else
// #define GETSTATE(m) (&_state)
// static struct module_tqapi _tqapi;
// #endif

#if PY_MAJOR_VERSION >= 3

static int tqapi_traverse(PyObject *m, visitproc visit, void *arg)
{
    //Py_VISIT(GETSTATE(m)->error);
    return 0;
}

static int tqapi_clear(PyObject *m)
{
    //Py_CLEAR(GETSTATE(m)->error);
    return 0;
}


static struct PyModuleDef module_def = {
    PyModuleDef_HEAD_INIT,
    "_tqapi",
    NULL,
    sizeof(struct module_tqapi),
    tqapi_methods,
    NULL,
    tqapi_traverse,
    tqapi_clear,
    NULL
};

#define INITERROR return NULL

PyMODINIT_FUNC PyInit__tqapi(void)

#else

#define INITERROR return

PyMODINIT_FUNC init_tqapi(void)
#endif
{
    PyEval_InitThreads();


#if PY_MAJOR_VERSION >= 3
    PyObject *module = PyModule_Create(&module_def);
#else
    PyObject *module = Py_InitModule("_tqapi", tqapi_methods);
#endif

    if (module == NULL)
        INITERROR;
    
    // struct module_tqapi *st = GETTQAPI(module);

    // st->error = PyErr_NewException("myextension.Error", NULL, NULL);
    // if (st->error == NULL) {
    //     Py_DECREF(module);
    //     INITERROR;
    // }

#if PY_MAJOR_VERSION >= 3
    return module;
#endif
}

// PyMODINIT_FUNC API_EXPORT init_tqapi(void)
// {
//     PyEval_InitThreads();

//     Py_InitModule("_tqapi", Methods);
// }

PyObject* _wrap_set_params(PyObject* self, PyObject *args, PyObject* kwargs)
{
    const char* key;
    const char* value;

    if (!PyArg_ParseTuple(args, "ss", (char*)&key, (char*)&value))
        return NULL;

    set_params(key, value);
    Py_RETURN_NONE;
}



#ifdef BUILD_API_TEST

int main(int argc, char** argv)
{
    Py_Initialize();

#if PY_MAJOR_VERSION >= 3
    PyInit__tqapi();

    Py_Main(0, nullptr);
#else
    init_tqapi();
    Py_Main(argc, argv);
#endif



    return 0;
}

#endif
