import { async } from '@angular/core/testing';

fdescribe('1 Promise without async operator or function, expect independent on promise', () => {
  it('1.1 FAILS on expect', () => {
    let flag = false;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    });
    expect(flag).toBeTruthy();
  });

  it('1.2 FAILS on expect', () => {
    let flag = false;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    });
    expect(flag).toBeTruthy();
  }, 10000);
});

fdescribe('2 Promise without async operator or function, expect in then clause', () => {
  it('2.1 SUCCEEDS because test finishes before expect is invoked', () => {
    let flag = false;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    }).then(() => {
      expect(flag).toBeTruthy();
    });
  });

  it('2.2 SUCCEEDS because test finishes before expect is invoked', () => {
    let flag = false;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    }).then(() => {
      expect(flag).toBeTruthy();
    });
  }, 10000);
});

fdescribe('3 Promise with async operator, expect in then clause', () => {
  it('3.1 FAILS by timeout', async(() => {
    let flag = false;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    }).then(() => {
      expect(flag).toBeTruthy();  // then clause is invoked anyway after the test is failed by timeout
    });
  }));

  it('3.2 SUCCEEDS because expect is invoked and timeout is increased', async(() => {
    let flag = false;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    }).then(() => {
      expect(flag).toBeTruthy();  // then clause is invoked
    });
  }), 10000);
});

fdescribe('4 Promise with async function, expect not in then clause', () => {
  it('4.1 FAILS on expect before promise is resolved', async(() => {  // FAILS on expect
    let flag = false;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    });
    expect(flag).toBeTruthy();
  }));

  it('4.2 FAILS on expect before promise is resolved', async(() => {  // FAILS on expect
    let flag = false;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    });
    expect(flag).toBeTruthy();  // then clause is invoked
  }), 10000);
});

fdescribe('5 Promise with await and async operator', () => {
  it('5.1 FAILS on timeout', async () => {
    let flag = false;
    await new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    });
    expect(flag).toBeTruthy();
  });

  it('5.2 SUCCEEDS', async () => {
    let flag = false;
    await new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    });
    expect(flag).toBeTruthy();
  }, 10000);
});

fdescribe('6 Promise in async-async. Same as 5', () => {
  it('6.1 FAILED by timeout', async(async () => {
    let flag = false;
    await new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    });
    expect(flag).toBeTruthy();
  }));

  it('6.2 SUCCEEDS', async(async () => {
    let flag = false;
    await new Promise((resolve) => {
      setTimeout(() => {
        flag = true;
        resolve();
      }, 6000);
    });
    expect(flag).toBeTruthy();
  }), 10000);
});

fdescribe('7 BeforeEach also has timeout', () => {
  beforeEach(async(() => {
    // following calls of beforeEach will have 10sec timeout
    jasmine.DEFAULT_TIMEOUT_INTERVAL = 10000;
    const p = new Promise((resolve) => {
      setTimeout(() => {
        resolve();
      }, 6000);
    });
  }));

  it('7.1 FAILED on timeout: BeforeEach uses 5sec timout', () => { });

  it('7.2 SUCCEEDS: BeforeEach uses 10sec timout', () => { });
});
